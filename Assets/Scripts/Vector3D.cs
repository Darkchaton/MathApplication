using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3D : MonoBehaviour
{
    // Classe non utilis�e car Unity a d�j� un syst�me de vecteurs int�gr� avec Vector3D. Mais dans le cas contraire, voici la classe que j'aurais utilis�e :

    //D�claration
    public float x, y, z;

    //Impl�mentation
    public Vector3D(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    //M�THODES

    // M�thode d'addition
    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
    }

    // M�thode de produit scalaire
    public float DotProduct(Vector3D other)
    {
        return x * other.x + y * other.y + z * other.z;
    }

    // M�thode pour obtenir la norme
    public float Magnitude()
    {
        return Mathf.Sqrt(x * x + y * y + z * z);
    }

    // M�thode pour normaliser le vecteur
    public Vector3D Normalize()
    {
        float mag = Magnitude();
        return new Vector3D(x / mag, y / mag, z / mag);
    }
}
