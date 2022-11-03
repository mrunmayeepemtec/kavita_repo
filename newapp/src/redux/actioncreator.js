import * as actiontypes from "./actiontypes"

export const increseValue = ()=>{
    return {
        types: actiontypes.INCREMENT
    }
}

export const decreaseValue = ()=>{
    return{
        type:actiontypes.DECREMENT
    }
}