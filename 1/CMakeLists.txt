cmake_minimum_required(VERSION 3.22)

project(wind)

# Set C++ standard
set(CMAKE_CXX_STANDARD 23)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_EXPORT_COMPILE_COMMANDS ON)

# Emscripten-specific configurations
if(BUILD_WASM)
  set(CMAKE_C_COMPILER "emcc")
  set(CMAKE_CXX_COMPILER "em++")
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -s WASM=1 -s SIDE_MODULE=1 -s ASSERTIONS=2 -s SAFE_HEAP=1 -s DEMANGLE_SUPPORT=1 -gsource-map -s DEMANGLE_SUPPORT=1")
  set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} -s WASM=1 -s SIDE_MODULE=1 -s ASSERTIONS=2 -s SAFE_HEAP=1 -s DEMANGLE_SUPPORT=1 -gsource-map -s DEMANGLE_SUPPORT=1")
endif()

# Include directories
set(HEADERS
    ./native/include/window.hpp
    ./native/include/renderer.hpp
)

set(SOURCES
    ./native/src/renderer.cpp
    ./native/src/window.cpp
)

# Add library target (shared library for WebAssembly)
add_library(${PROJECT_NAME} SHARED ${HEADERS} ${SOURCES})
target_include_directories(${PROJECT_NAME} PRIVATE ./native/include/)

if(BUILD_WASM)
  # Add WebAssembly specific linking flags
  set_target_properties(${PROJECT_NAME} PROPERTIES
    LINK_FLAGS "-s WASM=1 -s SIDE_MODULE=1"
  )
endif()

# Optionally, you can remove this if you're only building the library
# Add executable target (can be used for testing, otherwise can be removed)
add_executable(${PROJECT_NAME}-engine ${HEADERS} ${SOURCES} ./native/src/main.cpp)
target_include_directories(${PROJECT_NAME}-engine PRIVATE ./native/include/)
target_link_libraries(${PROJECT_NAME}-engine PRIVATE ${PROJECT_NAME})

# Optionally build only the library (remove executable if not needed)
