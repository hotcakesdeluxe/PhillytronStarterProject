using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Phillytron
{
    public class PlayerSpawner : MonoBehaviour
    {
        public GameObject player;
        public Transform[] spawnPoints;

        // Start is called before the first frame update
        void Start()
        {
            SpawnPlayers();
        }

        private void SpawnPlayers()
        {
            for (int i = 0; i < PhillytronPlayerManager.Instance.playerCount; i++)
            {
                if (PhillytronPlayerManager.Instance.player1SignedIn)
                {
                    GameObject player1 = Instantiate(player, spawnPoints[0]);
                    player1.GetComponent<SpriteRenderer>().color = PhillytronPlayerManager.Instance.player1Color;
                    player1.GetComponent<PlayerController>().input = PhillytronPlayerManager.Instance.playerInputs[0];
                }
                if (PhillytronPlayerManager.Instance.player2SignedIn)
                {
                    GameObject player2 = Instantiate(player, spawnPoints[1]);
                    player2.GetComponent<SpriteRenderer>().color = PhillytronPlayerManager.Instance.player2Color;
                    player2.GetComponent<PlayerController>().input = PhillytronPlayerManager.Instance.playerInputs[1];
                }
                if (PhillytronPlayerManager.Instance.player3SignedIn)
                {
                    GameObject player3 = Instantiate(player, spawnPoints[2]);
                    player3.GetComponent<SpriteRenderer>().color = PhillytronPlayerManager.Instance.player3Color;
                    player3.GetComponent<PlayerController>().input = PhillytronPlayerManager.Instance.playerInputs[2];
                }
                if (PhillytronPlayerManager.Instance.player4SignedIn)
                {
                    GameObject player4 = Instantiate(player, spawnPoints[3]);
                    player4.GetComponent<SpriteRenderer>().color = PhillytronPlayerManager.Instance.player4Color;
                    player4.GetComponent<PlayerController>().input = PhillytronPlayerManager.Instance.playerInputs[3];
                }
            }
        }
    }
}