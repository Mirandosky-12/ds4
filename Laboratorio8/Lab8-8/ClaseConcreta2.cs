﻿using System;

class ClaseConcreta2 : ClaseAbstracta
{
    protected override string tomarValor()
    {
        return "ClassConcreta2";
    }
    public override string prefixValor(string prefix)
    {
        return $"{prefix}ClaseConcreta2";
    }
}