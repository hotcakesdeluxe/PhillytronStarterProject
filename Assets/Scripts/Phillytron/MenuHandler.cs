using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace Phillytron
{
    public class MenuHandler : MonoBehaviour
    {
        public TMP_Text startTitleText;
        public TMP_Text timerText;
        [Header("Player Status Text")]
        public TMP_Text player1Status;
        public TMP_Text player2Status;
        public TMP_Text player3Status;
        public TMP_Text player4Status;

        private float _targetTime = 5f;
        
        // Start is called before the first frame update
        void Start()
        {
            startTitleText.text = "";
            timerText.text = "";
        }

        // Update is called once per frame
        void Update()
        {
            PlayerSignIn();
            if (PhillytronPlayerManager.Instance.playerCount > 0 && _targetTime > 0)
            {
                startTitleText.text = "GAME STARTS IN";
                _targetTime -= Time.deltaTime;
                int textTime = (int)_targetTime;
                timerText.text = textTime.ToString();
            }
            if(_targetTime <= 0)
            {
                SceneManager.LoadScene("Game");
            }
            
        }

        private void PlayerSignIn()
        {
            //sign Player 1 in and out
            if (Input.GetKeyDown(KeyCode.Period))
            {
                PhillytronPlayerManager.Instance.player1SignedIn = true;
                PhillytronPlayerManager.Instance.playerCount++;
                player1Status.text = "READY!";
                _targetTime = 5f;
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                PhillytronPlayerManager.Instance.player1SignedIn = false;
                PhillytronPlayerManager.Instance.playerCount--;
                player1Status.text = "Press Blue to Join";
                _targetTime = 5f;
            }
            
            //sign Player 2 in and out
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                PhillytronPlayerManager.Instance.player2SignedIn = true;
                PhillytronPlayerManager.Instance.playerCount++;
                player2Status.text = "READY!";
                _targetTime = 5f;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                PhillytronPlayerManager.Instance.player2SignedIn = false;
                PhillytronPlayerManager.Instance.playerCount--;
                player2Status.text = "Press Blue to Join";
                _targetTime = 5f;
            }
            
            //sign Player 3 in and out
            if (Input.GetKeyDown(KeyCode.G))
            {
                PhillytronPlayerManager.Instance.player3SignedIn = true;
                PhillytronPlayerManager.Instance.playerCount++;
                player3Status.text = "READY!";
                _targetTime = 5f;
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                PhillytronPlayerManager.Instance.player3SignedIn = false;
                PhillytronPlayerManager.Instance.playerCount--;
                player3Status.text = "Press Blue to Join";
                _targetTime = 5f;
            }
            
            //sign Player 4 in and out
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                PhillytronPlayerManager.Instance.player4SignedIn = true;
                PhillytronPlayerManager.Instance.playerCount++;
                player4Status.text = "READY!";
                _targetTime = 5f;
            }
            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                PhillytronPlayerManager.Instance.player4SignedIn = false;
                PhillytronPlayerManager.Instance.playerCount--;
                player4Status.text = "Press Blue to Join";
                _targetTime = 5f;
            }
        }
        
    }
}
