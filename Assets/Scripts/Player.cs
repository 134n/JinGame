using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private int speed;

    private PlayerControl playerControl;

    private void Start()

    {
        playerControl = new(speed, player);
    }

    private void Update()
    {
        playerControl.PlayerMove();
    }

    class PlayerControl
    {
        private readonly float speed;
        private readonly GameObject player;

        public PlayerControl(float speed, GameObject player)
        {
            this.speed = speed;
            this.player = player;
        }

        public void PlayerMove()
        {
            float speed = this.speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.UpArrow))
            {
                player.transform.position += speed * Vector3.forward.normalized;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                player.transform.position -= speed * Vector3.forward.normalized;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                player.transform.position += speed * Vector3.right.normalized;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                player.transform.position += speed * Vector3.left.normalized;
            }

        }
    }
}
