using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Phillytron
{
    public  class PhillytronPlayerManager : MonoBehaviour
    {
        public static PhillytronPlayerManager Instance;
        public int playerCount = 0;
        public bool player1SignedIn = false;
        public bool player2SignedIn = false;
        public bool player3SignedIn = false;
        public bool player4SignedIn = false;
        public Color player1Color;
        public Color player2Color;
        public Color player3Color;
        public Color player4Color;
        public PlayerInput[] playerInputs;

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        private void Update()
        {
            //you can handle the escape key however you want (i.e. it can bring up a pause menu on first press) but it must also close the application too
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}