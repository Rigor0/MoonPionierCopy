using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Abstract.Inputs
{
    public interface IPlayerInput
    {
        float horizontal { get; set; }
        float vertical {get; set; }
    }
}

