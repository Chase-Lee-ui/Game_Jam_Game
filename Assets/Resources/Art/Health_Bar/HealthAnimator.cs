﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthAnimator : MonoBehaviour {

    //[SerializeField] TextField HealthCount;
    [SerializeField] UnityEditor.Animations.AnimatorController HealthObject;
    [SerializeField] RuntimeAnimatorController UpdateHealth;

    // Start is called before the first frame update
    void Start() {
        //HealthObject.UnityEditor.Animations.AnimatorController = 
        // HealthObject = Resources.Load(UpdateHealth) as RuntimeAnimatorController;
        //HealthObject.runtimeAnimatorController = Resources.Load("Art/Health_Bar/health_3") as RuntimeAnimatorController;
        //Animator animator = gameObject.GetComponent<Animator>();
        //animator.runtimeAnimatorController = Resources.Load("health_2") as RuntimeAnimatorController;
    }

    void Update() {

    }

    public void updateAnimation() {
        // method that retrieves health
        //int healthCount = 3;
        //HealthObject.runtimeAnimatorController = Resources.Load(health_2.controller) as RuntimeAnimatorController;
    }


}
