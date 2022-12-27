using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project.Abstract.Movements;
using UnityEngine.AI;


namespace Project.Concreates.AI
{
    public class AI : IMove
    {
        NavMeshAgent navMeshAgent;
        public AI(NavMeshAgent _navmeshAgent)
        {
            navMeshAgent = _navmeshAgent;
        }
        void IMove.Movement(float _horizontal, float _vertical, Transform _treadMill)
        {
            _horizontal = _treadMill.position.x;
            _vertical = _treadMill.position.z;
            Vector3 destination = new Vector3(_horizontal, 0, _vertical);

            navMeshAgent.SetDestination(destination);
        }
    }
}

