using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{

    [Header("Components")]
    protected Animator animator;
    protected Sprite sprite;
    protected BoxCollider2D bc2D;
    protected Rigidbody2D rb2D; // I don't know if I need this here exactly.

    [Header("Properties")]
    [SerializeField] protected float maxHealth;
    [SerializeField] protected float currentHealth;
    [SerializeField] protected float movementSpeed;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<Sprite>();
        bc2D = GetComponent<BoxCollider2D>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
