using System.Threading.Tasks;
using System.Threading;
using UnityEngine;

public class Unit3 : MonoBehaviour
{
    public async Task<bool> WhatTaskFaster(CancellationToken ct, Task task1, Task task2)
    {
        Task<bool> task_1 = task1 as Task<bool>;
        Task<bool> task_2 = task2 as Task<bool>;
        Task<bool> result = await Task.WhenAny(task_1, task_2);

        if(result == task_1)
        {
            return true;
        }
        else if(result == task_2)
        {
            return false;
        }

        return false;
    }
}
