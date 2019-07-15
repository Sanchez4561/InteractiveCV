﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement movement;
    private PlayerAttack playerAttack;

    InputManager controls;

    private void Awake()
    {
        controls = new InputManager();

        controls.Gameplay.Melee.performed += inp => playerAttack.Attack();
        controls.Gameplay.Dash.performed += inp => movement.Dash();

        controls.Gameplay.Movement.performed += inp => movement.playerMove = inp.ReadValue<Vector2>();
        controls.Gameplay.Movement.canceled += inp => movement.playerMove = Vector2.zero;
    }

    void Start()
    {
        movement = GetComponent<PlayerMovement>();
        playerAttack = GetComponent<PlayerAttack>();
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }
}