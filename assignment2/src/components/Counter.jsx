import React, {useState} from 'react'
import './CSS/counter.css'

const Counter = () => {

    const [value, setValue] = useState(0);

    const increment = () =>{
        console.log("Incrementing...")
        setValue(value+1)
        console.log(`Counter = ${value}`)
    }

    const decrement =() =>{
        console.log("Decrementing...")
        setValue(value-1)
        console.log(`Counter = ${value}`)
    }
  return (
    <div className="contact-box">
      <h1>Counter</h1>
      <div>
        <button onClick={increment}>Increment (+)</button>
        <span>{value}</span>
        <button onClick={decrement}>Decrement (-)</button>
      </div>
    </div>
  )
}

export default Counter
