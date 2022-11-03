import * as actiontypes from "./actiontypes"

const InitialState ={
    Count: 0
}
export const reducer = (state=InitialState, action)=>{
    switch(action.type){
        case actiontypes.INCREMENT:
            return{
                ...state,
                count:state.Count+1
            
            }
            case actiontypes.DECREMENT:
            return{
                ...state,
                count:state.Count-1
            }
            default:
                return state
    }
}