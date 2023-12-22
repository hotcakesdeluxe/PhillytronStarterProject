using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Phillytron
{
    public class PlayerController : MonoBehaviour
    {
        public PlayerInput input;
        public float speed = 10;
        public GameObject blueButtonVisual;
        public GameObject purpleButtonVisual;
        public GameObject greenButtonVisual;

        // Update is called once per frame
        void Update()
        {
            PlayerMovement();
            ButtonTest();
        }

        private void PlayerMovement()
        {
            if (Input.GetKey(input.right))
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            }

            if (Input.GetKey(input.left))
            {
                transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
            }

            if (Input.GetKey(input.up))
            {
                transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
            }

            if (Input.GetKey(input.down))
            {
                transform.position -= new Vector3(0f, speed * Time.deltaTime, 0f);
            }
        }

        private void ButtonTest()
        {
            blueButtonVisual.SetActive(Input.GetKey(input.blueButton));
            purpleButtonVisual.SetActive(Input.GetKey(input.purpleButton));
            greenButtonVisual.SetActive(Input.GetKey(input.greenButton));
        }
    }
}