function(include_os file)
  if (BUILD_WASM)
    set(os_dir "wasm")
  elseif (UNIX)
    set(os_dir "unix")
  elseif (WIN32)
    set(os_dir "windows")
  else()
    message(FATAL_ERROR "Unsupported OS: ${CMAKE_SYSTEM_NAME}")
  endif()

  set(file_path "${CMAKE_SOURCE_DIR}/cmake/${os_dir}/${file}.cmake")

  include(${file_path})
endfunction()
