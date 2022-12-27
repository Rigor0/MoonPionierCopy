using System.Collections;
using System.Collections.Generic;
using Project.Abstract.Animations;
using UnityEngine;

namespace Project.Concreates.Animations
{
    public class PlayerAnimation : IAnimation
    {
        Animator animator;

        public PlayerAnimation(Animator _animator)
        {
            animator = _animator;
        }

        void IAnimation.MovementAnim(float _horizontal , float _vertical)
        {
            if (_horizontal != 0 || _vertical != 0)
            {
                animator.SetBool("move" , true);
            }
            else
            {
                animator.SetBool("move" , false);
            }
            
        }
    }
}

