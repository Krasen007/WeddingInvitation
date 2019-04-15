namespace Assets.myScripts
{
    using UnityEngine;

    public class PlaySound : MonoBehaviour
    {
        [SerializeField]
        private AudioSource audioData;

        // Start is called before the first frame update
        private void Start()
        {
            // Empty           
        }

        // Update is called once per frame
        private void Update()
        {
            // Empty
            if (Input.GetMouseButton(0))
            {
                audioData = GetComponent<AudioSource>();
                audioData.Play(0);
            }
        }        
    }
}
