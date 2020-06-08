using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoisManager : MonoBehaviour
{

    private bool FirstPlayer;

    public ChoisManager Invock { get { return this; } }

    private void Awake()
    {

        FirstPlayer = true;
    }

}
