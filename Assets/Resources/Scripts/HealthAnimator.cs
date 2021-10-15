using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthObjectAnimator : MonoBehaviour
{

    //[SerializeField] TextField HealthCount;
    [SerializeField] Animator HealthObject;

    // Start is called before the first frame update
    void Start()
    {
        //HealthObject.runtimeAnimatorController = Resources.Load("health_2") as RuntimeAnimatorController;
        Animator animator = gameObject.GetComponent<Animator>();
        animator.runtimeAnimatorController = Resources.Load("health_2") as RuntimeAnimatorController;
    }

    void Update() {

    }

    public void updateAnimation() {
        // method that retrieves health
        //int healthCount = 3;
        //HealthObject.runtimeAnimatorController = Resources.Load(health_2.controller) as RuntimeAnimatorController;
    }


}
