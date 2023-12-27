using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace Phillytron
{
    public class MenuHandler : MonoBehaviour
    {
        public PlayerInput player1Input;
        public PlayerInput player2Input;
        public PlayerInput player3Input;
        public PlayerInput player4Input;
        public TMP_Text startTitleText;
        public TMP_Text timerText;
        [Header("Player Status Text")]
        public TMP_Text player1Status;
        public TMP_Text player2Status;
        public TMP_Text player3Status;
        public TMP_Text player4Status;
        [Header("Player Leave Text")]
        public TMP_Text player1Leave;
        public TMP_Text player2Leave;
        public TMP_Text player3Leave;
        public TMP_Text player4Leave;

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
            else
            {
                startTitleText.text = "";
                timerText.text = "";
                _targetTime = 5f;
            }
            if(_targetTime <= 0)
            {
                SceneManager.LoadScene("Game");
            }
            
        }

        private void PlayerSignIn()
        {
            //sign Player 1 in and out
            if (!PhillytronPlayerManager.Instance.player1SignedIn)
            {
                if (Input.GetKeyDown(player1Input.blueButton) || 
                    Input.GetKeyDown(player1Input.purpleButton) || 
                    Input.GetKeyDown(player1Input.greenButton))
                {
                    PhillytronPlayerManager.Instance.player1SignedIn = true;
                    PhillytronPlayerManager.Instance.playerCount += 1;
                    player1Status.text = "READY!";
                    player1Leave.text = "LEAVE";
                    _targetTime = 5f;
                }
            }
            
            else if (Input.GetKeyDown(player1Input.purpleButton))
            {
                PhillytronPlayerManager.Instance.playerCount -= 1;
                player1Status.text = "Press ANY BUTTON to Join";
                player1Leave.text = "";
                _targetTime = 5f;
                PhillytronPlayerManager.Instance.player1SignedIn = false;
            }
            
            //sign Player 2 in and out
            if (!PhillytronPlayerManager.Instance.player2SignedIn)
            {
                if (Input.GetKeyDown(player2Input.blueButton) || 
                    Input.GetKeyDown(player2Input.purpleButton) || 
                    Input.GetKeyDown(player2Input.greenButton))
                {
                    PhillytronPlayerManager.Instance.player2SignedIn = true;
                    PhillytronPlayerManager.Instance.playerCount++;
                    player2Status.text = "READY!";
                    player2Leave.text = "LEAVE";
                    _targetTime = 5f;
                }
            }
            
            else if (Input.GetKeyDown(player2Input.purpleButton))
            {
                PhillytronPlayerManager.Instance.player2SignedIn = false;
                PhillytronPlayerManager.Instance.playerCount--;
                player2Status.text = "Press ANY BUTTON to Join";
                player2Leave.text = "";
                _targetTime = 5f;
            }
            //sign Player 3 in and out
            if (!PhillytronPlayerManager.Instance.player3SignedIn)
            {
                 
                if (Input.GetKeyDown(player3Input.blueButton) || 
                    Input.GetKeyDown(player3Input.purpleButton) || 
                    Input.GetKeyDown(player3Input.greenButton))
                {
                    PhillytronPlayerManager.Instance.player3SignedIn = true;
                    PhillytronPlayerManager.Instance.playerCount++;
                    player3Status.text = "READY!";
                    player3Leave.text = "LEAVE";
                    _targetTime = 5f;
                }
            }
           
            else if (Input.GetKeyDown(player3Input.purpleButton))
            {
                PhillytronPlayerManager.Instance.player3SignedIn = false;
                PhillytronPlayerManager.Instance.playerCount--;
                player3Status.text = "Press ANY BUTTON to Join";
                player3Leave.text = "";
                _targetTime = 5f;
            }
            
            //sign Player 4 in and out
            if (!PhillytronPlayerManager.Instance.player4SignedIn)
            {
                if (Input.GetKeyDown(player4Input.blueButton) || 
                    Input.GetKeyDown(player4Input.purpleButton) || 
                    Input.GetKeyDown(player4Input.greenButton))
                {
                    PhillytronPlayerManager.Instance.player4SignedIn = true;
                    PhillytronPlayerManager.Instance.playerCount++;
                    player4Status.text = "READY!";
                    player4Leave.text = "LEAVE";
                    _targetTime = 5f;
                }
            }
            
            else if (Input.GetKeyDown(player4Input.purpleButton))
            {
                PhillytronPlayerManager.Instance.player4SignedIn = false;
                PhillytronPlayerManager.Instance.playerCount--;
                player4Status.text = "Press ANY BUTTON to Join";
                player4Leave.text = "";
                _targetTime = 5f;
            }
        }
        
    }
}
