using Game.Gameplay.Effects;
using Unity.Entities;

namespace Game.Gameplay.GameEntities.View
{
    public struct DieParticleType : IComponentData
    {
        public ParticleType Value;
    }
}