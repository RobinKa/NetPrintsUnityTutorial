namespace NetPrintsUnityTutorial
{
    public class PlayerController : UnityEngine.MonoBehaviour
    {
        public System.Single speed;
        private UnityEngine.Rigidbody rb;
        // Method Start
        private void Start()
        {
            // Variables
            UnityEngine.Rigidbody varRigidbody = default(UnityEngine.Rigidbody);
            UnityEngine.Rigidbody varT = default(UnityEngine.Rigidbody);
            // Set rb
            // GetComponent
            varT = this.GetComponent<UnityEngine.Rigidbody>();
            this.rb = varT;
            varRigidbody = varT;
        // Return
        }

        // Method FixedUpdate
        private void FixedUpdate()
        {
            // Variables
            System.Exception varException = default(System.Exception);
            UnityEngine.Rigidbody varRigidbody = default(UnityEngine.Rigidbody);
            UnityEngine.Vector3 varVector3 = default(UnityEngine.Vector3);
            UnityEngine.Vector3 varVector32 = default(UnityEngine.Vector3);
            System.Single varSingle = default(System.Single);
            System.Single varSingle2 = default(System.Single);
            System.Single varSingle3 = default(System.Single);
            // AddForce
            // Get rb
            varRigidbody = this.rb;
            // Input.GetAxis
            varSingle = UnityEngine.Input.GetAxis("Horizontal");
            // Input.GetAxis
            varSingle2 = UnityEngine.Input.GetAxis("Vertical");
            // Get speed
            varSingle3 = this.speed;
            // Construct Vector3
            varVector32 = new UnityEngine.Vector3(varSingle, 0F, varSingle2);
            // Operator Multiply
            varVector3 = varVector32 * varSingle3;
            varRigidbody.AddForce(varVector3);
        // Return
        }
    }
}