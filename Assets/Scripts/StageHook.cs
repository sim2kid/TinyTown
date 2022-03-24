using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageHook : MonoBehaviour
{
    public void PickUpPileOne()
    {
        Stage.Instance.PickUpPileOne();
    }
    public void PickUpPileTwo()
    {
        Stage.Instance.PickUpPileTwo();
    }
}
