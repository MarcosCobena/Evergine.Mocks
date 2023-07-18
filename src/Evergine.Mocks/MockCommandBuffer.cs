using Evergine.Common.Graphics;
using Evergine.Common.Graphics.Raytracing;
using Evergine.Mathematics;

namespace Evergine.Mocks
{
    internal class MockCommandBuffer : CommandBuffer
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override GraphicsContext GraphicsContext => throw new NotImplementedException();

        public override void Begin()
        {
        }

        public override void BeginDebugMarker(string label)
        {
        }

        public override void BeginQuery(QueryHeap heap, uint index)
        {
            throw new NotImplementedException();
        }

        public override BottomLevelAS BuildRaytracingAccelerationStructure(BottomLevelASDescription blas)
        {
            throw new NotImplementedException();
        }

        public override TopLevelAS BuildRaytracingAccelerationStructure(TopLevelASDescription tlas)
        {
            throw new NotImplementedException();
        }

        public override void Commit()
        {
        }

        public override void Dispatch(uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            throw new NotImplementedException();
        }

        public override void DispatchIndirect(Common.Graphics.Buffer argBuffer, uint offset)
        {
            throw new NotImplementedException();
        }

        public override void DispatchRays(DispatchRaysDescription description)
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override void Draw(uint vertexCount, uint startVertexLocation = 0)
        {
            throw new NotImplementedException();
        }

        public override void DrawIndexed(uint indexCount, uint startIndexLocation = 0, uint baseVertexLocation = 0)
        {
            throw new NotImplementedException();
        }

        public override void DrawIndexedInstanced(uint indexCountPerInstance, uint instanceCount, uint startIndexLocation = 0, uint baseVertexLocation = 0, uint startInstanceLocation = 0)
        {
            throw new NotImplementedException();
        }

        public override void DrawIndexedInstancedIndirect(Common.Graphics.Buffer argBuffer, uint offset, uint drawCount, uint stride)
        {
            throw new NotImplementedException();
        }

        public override void DrawInstanced(uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation = 0, uint startInstanceLocation = 0)
        {
            throw new NotImplementedException();
        }

        public override void DrawInstancedIndirect(Common.Graphics.Buffer argBuffer, uint offset, uint drawCount, uint stride)
        {
            throw new NotImplementedException();
        }

        public override void EndDebugMarker()
        {
        }

        public override void EndQuery(QueryHeap heap, uint index)
        {
            throw new NotImplementedException();
        }

        public override void GenerateMipmaps(Texture texture)
        {
            throw new NotImplementedException();
        }

        public override void InsertDebugMarker(string label)
        {
            throw new NotImplementedException();
        }

        public override void Reset()
        {
            throw new NotImplementedException();
        }

        public override void ResourceBarrierUnorderedAccessView(Common.Graphics.Buffer buffer)
        {
            throw new NotImplementedException();
        }

        public override void ResourceBarrierUnorderedAccessView(Texture texture)
        {
            throw new NotImplementedException();
        }

        public override void SetIndexBuffer(Common.Graphics.Buffer buffer, IndexFormat format = IndexFormat.UInt16, uint offset = 0)
        {
            throw new NotImplementedException();
        }

        public override void SetResourceSet(ResourceSet resourceSet, uint index = 0, uint[] constantBufferOffsets = null!)
        {
            throw new NotImplementedException();
        }

        public override void SetScissorRectangles(Rectangle[] rectangles)
        {
        }

        public override void SetVertexBuffer(uint slot, Common.Graphics.Buffer buffer, uint offset)
        {
            throw new NotImplementedException();
        }

        public override void SetVertexBuffers(Common.Graphics.Buffer[] buffers, int[] offsets)
        {
            throw new NotImplementedException();
        }

        public override void SetViewports(Viewport[] viewports)
        {
        }

        public override void UpdateRaytracingAccelerationStructure(ref TopLevelAS tlas, TopLevelASDescription newDescription)
        {
            throw new NotImplementedException();
        }

        public override void WriteTimestamp(QueryHeap heap, uint index)
        {
            throw new NotImplementedException();
        }

        protected override void BeginRenderPassInternal(ref RenderPassDescription description)
        {
        }

        protected override void Blit(Texture source, uint sourceX, uint sourceY, uint sourceZ, uint sourceMipLevel, uint sourceBasedArrayLayer, Texture destination, uint destinationX, uint destinationY, uint destinationZ, uint destinationMipLevel, uint destinationBasedArrayLayer, uint layerCount)
        {
            throw new NotImplementedException();
        }

        protected override void CopyBufferDataToInternal(Common.Graphics.Buffer origin, Common.Graphics.Buffer destination, uint sizeInBytes, uint sourceOffset = 0, uint destinationOffset = 0)
        {
            throw new NotImplementedException();
        }

        protected override void CopyTextureDataToInternal(Texture source, uint sourceX, uint sourceY, uint sourceZ, uint sourceMipLevel, uint sourceBasedArrayLayer, Texture destination, uint destinationX, uint destinationY, uint destinationZ, uint destinationMipLevel, uint destinationBasedArrayLayer, uint width, uint height, uint depth, uint layerCount)
        {
            throw new NotImplementedException();
        }

        protected override void EndInternal()
        {
        }

        protected override void EndRenderPassInternal()
        {
        }

        protected override void SetComputePipelineStateInternal(ComputePipelineState pipeline)
        {
            throw new NotImplementedException();
        }

        protected override void SetGraphicsPipelineStateInternal(GraphicsPipelineState pipeline)
        {
            throw new NotImplementedException();
        }

        protected override void SetRaytracingPipelineStateInternal(RaytracingPipelineState pipeline)
        {
            throw new NotImplementedException();
        }

        protected override void UpdateBufferDataInternal(Common.Graphics.Buffer buffer, IntPtr source, uint sourceSizeInBytes, uint destinationOffsetInBytes = 0)
        {
            throw new NotImplementedException();
        }
    }
}
