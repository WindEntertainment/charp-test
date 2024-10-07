#include "logger.hpp"
#include "renderer.hpp"
#include "window.hpp"

extern "C" {
__attribute__((export)) int add(int a, int b) {
  return a + b;
}
// bool windInitRenderer();
// void* windCreateWindow(int position_x, int position_y, int width, int height, char* title);
// bool windPostInitRenderer();
}

int main() {
  // windInitRenderer();
  // windCreateWindow(0, 0, 800, 600, (char*)"Hello, From C++");
  return EXIT_SUCCESS;
}
