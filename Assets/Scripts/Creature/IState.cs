using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    public IState NextState { get; }

    public void Begin();
    public void Update();
    public void End();
}
