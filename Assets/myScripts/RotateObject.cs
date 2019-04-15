namespace Assets.myScripts
{
    using UnityEngine;

    public class RotateObject : MonoBehaviour
    {
        [SerializeField]
        private int rotateSpeed = 75;

        [SerializeField]
        private Vector3 direction = Vector3.forward;

        // Start is called before the first frame update
        private void Start()
        {
            // Empty
        }

        // Update is called once per frame
        private void Update()
        {
            transform.Rotate(this.direction * Time.deltaTime * rotateSpeed);
        }
    }
}