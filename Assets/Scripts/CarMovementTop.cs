using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ARCHIVO HEREDERO DE CarMovement, DE MANERA QUE USA SU MISMO COMPORTAMIENTO CON LOS CAMBIOS QUE SE APLIQUEN A CONTINUACIÓN
public class CarMovementTop : CarMovement
{
    protected override void Awake()
    {
        // INVERTIMOS LA VELOCIDAD PARA QUE VAYA HACIA LA OTRA DIRECCION
        speed *= -1;
        base.Awake();
    }
}
