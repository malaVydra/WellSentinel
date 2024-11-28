using UnityEngine;
using UnityEngine.Events;

public class HealthComponent : MonoBehaviour
{
    [HideInInspector] public UnityEvent HealthLost = new UnityEvent();
    
    [SerializeField] private float maxHealth;
    private float health;
    public float Health => health;

    public void ChangeHealth(float _amount)
    {
        health += _amount;

        if (health <= 0)
        {
            HealthLost?.Invoke();
        }
    }
    private void Awake()
    {
        health = maxHealth;
    }
}