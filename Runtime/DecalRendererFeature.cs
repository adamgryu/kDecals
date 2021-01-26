using UnityEngine.Rendering.Universal;

namespace kTools.Decals
{
    sealed class DecalRendererFeature : ScriptableRendererFeature
    {
#region Fields
        DecalRenderPass m_RenderPass;
#endregion

#region Initialization
        public override void Create()
        {
            name = "Decals";
            m_RenderPass = new DecalRenderPass();
        }
#endregion
        
#region RenderPass
        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            // Enqueue passes
            renderer.EnqueuePass(m_RenderPass);
        }
#endregion
    }
}
