using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class interaction : MonoBehaviour
    {
    public dialogue dialogue;
        public LayerMask myLayer;
        public Transform myObj;
        [SerializeField] private float radius;
        private bool playerDetector;

        void Update()
        {
            playerDetector = Physics2D.OverlapCircle(myObj.position, radius, myLayer);
            if (playerDetector)
            {
                if (Input.GetKey(KeyCode.E))
                {
                FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
                }
                
            }
        }
    }


