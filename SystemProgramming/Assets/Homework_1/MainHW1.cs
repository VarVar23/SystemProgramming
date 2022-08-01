using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class MainHW1 : MonoBehaviour
{
    [SerializeField] private Unit _task1;
    [SerializeField] private Unit2 _task2;
    [SerializeField] private Unit3 _task3;


    private CancellationTokenSource _cancellationTokenSource;
    private CancellationToken _cancellationToken;
    private Task<bool> t1;
    private Task<bool> t2;

    private void Awake()
    {
        _cancellationTokenSource = new CancellationTokenSource();
        _cancellationToken = _cancellationTokenSource.Token; 
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _task1.ReceiveHealing();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            t1 = _task2.Task1Async(_cancellationToken);
            t2 = _task2.Task2Async(_cancellationToken);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log(_task3.WhatTaskFaster(_cancellationToken, t1, t2).Result);
        }
    }
}
