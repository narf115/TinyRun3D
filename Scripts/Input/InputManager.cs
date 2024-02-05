using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.InputSystem.Controls;

public class InputManager : MonoBehaviour
{
    public static InputManager ip;
    private InputActions nc;
    public float movevalue;
    public float select;
    public float IsPressed;
    public float IsCheat;
    public float IsGode;
    public float IsFol;
    public float IsL1;
    public float IsL2;
    public float IsL3;
    public float IsL4;

    private void Start()
    {
        if (ip == null)
            ip = this;

       
    }
    private void Awake()
    {
        nc = new InputActions();
       
        nc.Player.Move.performed += OnPlayerMove;
        nc.Player.Move.canceled += OnPlayerMove;

       nc.Player.inv.started += OnPlayerInv;
      nc.Player.inv.canceled += OnPlayerInv;
        nc.Player.ele.started += OnSelected;
        nc.Player.ele.canceled += OnSelected;
       
    }
    public void OnSelected(InputAction.CallbackContext cx)
    {

        select = cx.ReadValue<float>();

    }
    public void OnPlayerMove(InputAction.CallbackContext cx)
    {

        movevalue = cx.ReadValue<float>();

    }
    public void OnPlayerInv(InputAction.CallbackContext cx)
    {
        IsPressed = cx.ReadValue<float>();

    }
   /* public void OnPlayerGode(InputAction.CallbackContext cx)
    {
        IsGode = cx.ReadValue<float>();

    }
    public void OnPlayerFol(InputAction.CallbackContext cx)
    {
        IsFol = cx.ReadValue<float>();

    }
    public void OnPlayerL1(InputAction.CallbackContext cx)
    {
        IsL1 = cx.ReadValue<float>();

    }
    public void OnPlayerL2(InputAction.CallbackContext cx)
    {
        IsL2 = cx.ReadValue<float>();

    }
    public void OnPlayerL3(InputAction.CallbackContext cx)
    {
        IsL3 = cx.ReadValue<float>();

    }
    public void OnPlayerL4(InputAction.CallbackContext cx)
    {
        IsL4 = cx.ReadValue<float>();

    } */

    private void OnEnable()
    {
         nc.Enable();
    }
     private void OnDisable()
     {
       nc.Disable();
      }
}
