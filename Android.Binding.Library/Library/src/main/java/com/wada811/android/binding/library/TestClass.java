package com.wada811.android.binding.library;

import android.content.Context;
import android.widget.Toast;

public class TestClass implements TestInterface{

    public int anInt = 1;
    public long aLong = Integer.MAX_VALUE - (-anInt);
    public float aFloat = 0.1f;
    public double aDouble = Double.MAX_VALUE;
    public boolean aBoolean = true;
    public String aString = "test";

    public TestClass(){

    }
    public TestClass(int anInt){
        this.anInt = anInt;
    }
    public TestClass(long aLong){
        this.aLong = aLong;
    }
    public TestClass(float aFloat){
        this.aFloat = aFloat;
    }
    public TestClass(double aDouble){
        this.aDouble = aDouble;
    }
    public TestClass(boolean aBoolean){
        this.aBoolean = aBoolean;
    }
    public TestClass(String aString){
        this.aString = aString;
    }

    @Override
    public void toast(Context context, String text){
        Toast.makeText(context, text, Toast.LENGTH_LONG).show();
    }

    @Override
    public String toString(){
        return getClass().getSimpleName() + "{"
            + "anInt: " + anInt + "," + "\n"
            + "aLong: " + aLong + "," + "\n"
            + "aFloat: " + aFloat + "," + "\n"
            + "aDouble: " + aDouble + "," + "\n"
            + "aBoolean: " + aBoolean + "," + "\n"
            + "aString: " + aString + "\n"
            + "}";
    }
}
