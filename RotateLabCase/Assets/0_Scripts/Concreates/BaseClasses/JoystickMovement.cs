using System.Collections;
using System.Collections.Generic;
using Project.Abstract.Movements;
using UnityEngine;
using UnityEngine.AI;
using Project.Concreates.Rotations;
using Project.Abstract.Rotations;

namespace Project.Concreates.Movements
{
    public class JoystickMovement : IMove, IRotate
    {
        NavMeshAgent navMeshAgent;
        public static bool isMoving;
        public JoystickMovement(NavMeshAgent _navmeshAgent)
        {
            navMeshAgent = _navmeshAgent;
        }

        void IRotate.SetRotation(float _horizontal, float _vertical, Transform _transform)
        {
            if (_horizontal != 0 || _vertical != 0)
            {
                isMoving = true;
                Vector3 direction = Vector3.forward * _vertical + Vector3.right * _horizontal;
                _transform.rotation = Quaternion.Slerp(_transform.rotation, Quaternion.LookRotation(direction)
                , 10 * Time.deltaTime);
            }
            else
            {
                isMoving = false;
            }
        }

        void IMove.Movement(float _horizontal, float _vertical, Transform _transform)
        {
            Vector3 inputVector = new Vector3(_horizontal, 0, _vertical);
            Vector3 setNavmesh = _transform.localPosition + inputVector;

            navMeshAgent.SetDestination(setNavmesh);
        }
    }
}

