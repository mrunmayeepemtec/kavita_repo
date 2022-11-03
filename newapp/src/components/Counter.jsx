import React from 'react'
import { increseValue, decreaseValue } from '../redux/actioncreator'
import {useSelector, useDispatch} from 'react-redux'

const Counter = () => {

    const myState=useSelector(state=>state.ourState.count)
    const dispatch=useDispatch()
    console.log("MyState", myState)
  return (
    <div>
      <h1>Counter</h1>
      <button onClick={()=>dispatch(increseValue)}>Increment</button>
      <p>{myState}</p>
      <button onClick={()=>dispatch(decreaseValue)}>Decrement</button>
    </div>
  )
}

export default Counter
