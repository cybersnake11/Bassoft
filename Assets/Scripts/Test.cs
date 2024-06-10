using UnityEngine;

namespace Bassoft
{
    public class Test : MonoBehaviour
    {
        private void Start()
        {
            print(new Vector3(30,10,10));
            print(new Vector3(30,10,10).normalized);
            print(new Vector3(30, 10, 10).normalized.magnitude);
            print("----");
            print(new Vector3(0,3,1).normalized);
        }

        private void Update()
        {

        }
    }
}
