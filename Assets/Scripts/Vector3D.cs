using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3D : MonoBehaviour
{
    // Classe non utilisée car Unity a déjà un système de vecteurs intégré avec Vector3D. Mais dans le cas contraire, voici la classe que j'aurais utilisée :

    //Déclaration
    public float x, y, z;

    //Implémentation
    public Vector3D(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    //MÉTHODES

    // Méthode d'addition
    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
    }

    // Méthode de produit scalaire
    public float DotProduct(Vector3D other)
    {
        return x * other.x + y * other.y + z * other.z;
    }

    // Méthode pour obtenir la norme
    public float Magnitude()
    {
        return Mathf.Sqrt(x * x + y * y + z * z);
    }

    // Méthode pour normaliser le vecteur
    public Vector3D Normalize()
    {
        float mag = Magnitude();
        return new Vector3D(x / mag, y / mag, z / mag);
    }
}
