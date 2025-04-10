using UnityEngine;

namespace KinematicCharacterController
{
    [CreateAssetMenu]
    public class KinematicCharacterSettings : ScriptableObject
    {
        /// <summary>
        /// Determines if the system simulates automatically. If true, the simulation is done on FixedUpdate
        /// </summary>
        public bool AutoSimulation = true;

        /// <summary>
        /// Should interpolation of characters and PhysicsMovers be handled
        /// </summary>
        public bool Interpolate = true;

        /// <summary>
        /// Initial capacity of the system's list of Motors (will resize automatically if needed, but setting a high
        /// initial capacity can help preventing GC allocs)
        /// </summary>
        public int MotorsListInitialCapacity = 100;

        /// <summary>
        /// Initial capacity of the system's list of Movers (will resize automatically if needed, but setting a high
        /// initial capacity can help preventing GC allocs)
        /// </summary>
        public int MoversListInitialCapacity = 100;
    }
}