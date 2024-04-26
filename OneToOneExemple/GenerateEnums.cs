
// Definition of the buffers for the OpenGL API
enum OpenGLBuffers
{
    None = 0,
    Vertex = 1 << 1,
    Index = 1 << 2,
    Constant = 1 << 3,
    Count = 4,
};

// Definition of the buffers for the Direct3D API
enum Direct3DBuffers
{
    None = 0,
    Vertex = 1 << 1,
    Index = 1 << 2,
    Constant = 1 << 3,
    Count = 4,
};

// Definition of the buffers for the Vulkan API
enum VulkanBuffers
{
    None = 0,
    Vertex = 1 << 1,
    Index = 1 << 2,
    Constant = 1 << 3,
    Count = 4,
};
