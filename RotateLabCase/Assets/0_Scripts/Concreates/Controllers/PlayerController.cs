using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project.Abstract.Inputs;
using Project.Concreates.Inputs;
using Project.Abstract.Movements;
using Project.Concreates.Movements;
using Project.Concreates.Rotations;
using Project.Abstract.Rotations;
using Project.Abstract.Animations;
using Project.Concreates.Animations;
using UnityEngine.AI;

namespace Project.Concreates.Controllers
{
    [RequireComponent(typeof(NavMeshAgent),typeof(Animator),typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        IPlayerInput playerInput;
        IMove playerMovement;
        IRotate playerRotate;
        IAnimation playerAnim;
        
    
        private void Start() 
        {
            playerInput = GetComponent<JoystickInput>();
            playerMovement = new JoystickMovement(GetComponent<NavMeshAgent>());
            playerRotate = new JoystickMovement(GetComponent<NavMeshAgent>());
            playerAnim = new PlayerAnimation(GetComponent<Animator>());
        }

        private void Update() 
        {
            playerMovement.Movement(playerInput.horizontal,playerInput.vertical,transform);
            playerRotate.SetRotation(playerInput.horizontal,playerInput.vertical,transform);
            playerAnim.MovementAnim(playerInput.horizontal,playerInput.vertical);
            
            if (OpenAreaManager.isLevelFinish)
            {
                gameObject.SetActive(false);
            }
        }
    }
}

