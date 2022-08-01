using System.Collections;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private int _health = 0;
    [SerializeField] private int _maxHp;
    [SerializeField] private float _timeRecoveryHp;

    public void ReceiveHealing()
    {
        Debug.Log("Task_1");
        StopCoroutine(RecoveryHp());
        StartCoroutine(RecoveryHp());
    }

    private IEnumerator RecoveryHp()
    {
        float timePassed = 0;
        float timeWait = 0.5f;

        while(timePassed < _timeRecoveryHp && _health < _maxHp)
        {
            _health += 5;
            yield return new WaitForSeconds(timeWait);
            timePassed += timeWait;
            Debug.Log("HP: " + _health);
        }
    }
}
