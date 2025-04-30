using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed = 3f;
        public float blinkSpeed = 10f;
        public float blinkDuration = 0.1f;
        public float blinkCooldown = 1f;
        public bool IsBlinking => isBlinking;
        
        private Animator animator;
        private Rigidbody2D rb;
        private bool isBlinking = false;
        private float lastBlinkTime = -Mathf.Infinity;
        private Vector2 moveDir;

        private void Start()
        {
            animator = GetComponent<Animator>();
            rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            HandleInput();

            if (!isBlinking)
            {
                rb.linearVelocity = speed * moveDir;
            }

            animator.SetBool("IsMoving", moveDir.magnitude > 0);
        }

        void HandleInput()
        {
            Vector2 dir = Vector2.zero;

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                dir.x = -1;
                animator.SetInteger("Direction", 3);
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                dir.x = 1;
                animator.SetInteger("Direction", 2);
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                dir.y = 1;
                animator.SetInteger("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                dir.y = -1;
                animator.SetInteger("Direction", 0);
            }

            dir.Normalize();
            moveDir = dir;
            if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) && Time.time >= lastBlinkTime + blinkCooldown && dir != Vector2.zero)
            {
                StartCoroutine(Blink(dir));
            }
        }

        IEnumerator Blink(Vector2 direction)
        {
            isBlinking = true;
            lastBlinkTime = Time.time;

            rb.linearVelocity = direction * blinkSpeed;

            yield return new WaitForSeconds(blinkDuration);

            rb.linearVelocity = Vector2.zero;
            isBlinking = false;
        }
    }
