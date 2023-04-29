using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public abstract class BaseCharacter : MonoBehaviour
{

    [Header("Components")]
    protected SpriteRenderer spriteRenderer;
    protected Animator animator;
    protected Rigidbody2D rigidBody2D; 
    protected BoxCollider2D boxColider2D;

    [Header("Properties")]
    [SerializeField] protected float maxHealth = 100;
    [SerializeField] protected float currentHealth;
    [SerializeField] protected float baseMovementSpeed = 2; // Character's base speed. Never changed.
    [SerializeField] protected float currentMovementSpeed; // Character's speed used in movement, this property can be changed.

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxColider2D = GetComponent<BoxCollider2D>();
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        rigidBody2D.isKinematic = true; // Note: Might change, currently kinematic is perfect.
        currentHealth = maxHealth;
        currentMovementSpeed = baseMovementSpeed;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
    }

    public float GetMovementSpeed()
    {
        return currentMovementSpeed;
    }

    public void SetMovementSpeed(float newSpeed)
    {
        currentMovementSpeed = newSpeed;
    }
}
