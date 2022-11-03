import React, { useState } from 'react'
import FormInput from './FormInput'
import './CSS/registration.css'

const BookTable = ({email, password}) => {
    const [values, setValues] = useState({
        email: '',
        password: '',
    });

    const onChange = (e) =>{
        setValues({ ...values, [e.target.name] : e.target.value})
    }

    const handleSubmit = (e) =>{
        e.preventDefault();

    };

    console.log(values);

    const inputs = [
        {
            id: 1,
            name: "username",
            type: "text",
            placeholder: "Username",
            errorMessage: "Username shoud be 3-16 characters and shouldn't include any special character",
            label: "username",
            pattern: "^[A-Za-z0-9]{3,16}$",
            required: true
        },
        {
            id: 2,
            name: "email",
            type: "email",
            placeholder: "Email",
            errorMessage: "It should be a valid email address!",
            label: "Email",
            required: true
        },
        {
            id: 3,
            name: "startdate",
            type: "date",
            label: "startdate",
            required: true
        },
        {
            id: 4,
            name: "enddate",
            type: "date",  
            label: "enddate",
            required: true
        },
        {
            id: 5,
            name: "terms",
            type: "checkbox",
            errorMessage: "clik on me",
            required: true
        }
    ];

  return (
    <div className="registration">
      <form onSubmit={handleSubmit}>
        <h1>Booking Table</h1>
        {inputs.map((input)=>(
            <FormInput 
                key={input.id} 
                {...input} 
                value={values[input.name]} 
                onChange={onChange} 
            />
        ))}
        <p>Click Me</p>
          <button>Book</button>
        
            </form>
    </div>
  )
}

export default BookTable;
