/// © Quantumacy SASU 2024
/// Author: Étienne Alby
/// BSD 3-Clause Licence (see attached LICENCE.TXT)

#include "../Generated/VulkanBuffers.h"

int main(int argc, char** argv)
{
  renderer::VulkanWrapper vulkanWrapper;

  std::vector<math::vec3f> fakeData = { {0.0f, 1.0f, 2.0f,},{3.0f, 4.0f, 5.0f,} };
  vulkanWrapper.SetVertexBuffers(fakeData);

  return 0;
}