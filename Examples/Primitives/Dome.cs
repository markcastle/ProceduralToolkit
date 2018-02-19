using UnityEngine;

namespace ProceduralToolkit.Examples.Primitives
{
    [RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
    public class Dome : MonoBehaviour
    {
        public float radius = 1f;
        public int horizontalSegments = 16;
        public int verticalSegments = 16;
        public float domeDegrees = 240f;
        public bool buildFromBottomUp = true;
        public bool flipY = false;

        private void Start()
        {
            GetComponent<MeshFilter>().mesh = MeshDraft.Dome(radius, horizontalSegments, verticalSegments, true, domeDegrees).ToMesh();

        }
    }
}
