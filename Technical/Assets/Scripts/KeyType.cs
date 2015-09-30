using UnityEngine;
using System.Collections;

public enum KeyType{
    NUMBER_KEY = 0,  //Phim so
    CHARACTER_KEY = 1, //Ky tu: . , 
    OPERATOR_KEY = 2, //Toán tử: + , - , x, \
    FUNC_KEY = 3, //Hàm: Sin, Cos, Tan, Log
    APPFUNC_KEY = 4, //Phim chức năng chuyển đổi hàm: SHIFT,... Tắt nguồn: OFF
    OTHER_KEY = 5
}
