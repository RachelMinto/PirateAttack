using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectileOrigin;
    GameObject projectileParent;

    const string PROJECTILE_PARENT_NAME = "Projectiles";

	void Start () {
        CreateProjectileParent();
        Fire();
	}

    private void CreateProjectileParent()
    {
        projectileParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!projectileParent)
        {
            projectileParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
    }
	
    void Fire () {
        GameObject newProjectile = Instantiate(
            projectile,
            projectileOrigin.transform.position,
            Quaternion.identity
        ) as GameObject;

        newProjectile.transform.parent = projectileParent.transform;
    }
}
