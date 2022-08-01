using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Unit2 : MonoBehaviour
{
    public async Task<bool> Task1Async(CancellationToken ct)
    {
        if (ct.IsCancellationRequested) return false;

        await Task.Delay(1000);
        Debug.Log("«адача 1 завершена после 1 секунды ожидани€");

        return true;
    }

    public async Task<bool> Task2Async(CancellationToken ct)
    {
        if (ct.IsCancellationRequested) return false;

        int countUpdate = 0;

        if(countUpdate < 60)
        {
            countUpdate++;
            await Task.Yield();
        }
       
        Debug.Log("«адача 2 завершена после 60 кадров ожидани€");
        return true;
    }
}
