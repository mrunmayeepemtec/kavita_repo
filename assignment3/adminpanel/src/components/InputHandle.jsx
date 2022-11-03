import React, {useState} from 'react'
import './CSS/addhotel.css'
import { inputs } from './inputs'
import FormInput from './FormInput'

const InputHandle = () => {
    
        const [values, setValues] = useState({
            id: '',
            name: '',
            address: '',
            rating: '',
            email: ''
        });

        const onChange = (e) => {
            setValues({ ...values, [e.target.name]: e.target.value })
        }

        const handleSubmit = (e) => {
            e.preventDefault();
        };
        console.log(values);

        return (
            <div>
                <div className="addhotel">
                    <form onSubmit={handleSubmit}>
                        <h1>Add Hotel</h1>
                        {inputs.map((input) => (
                            <FormInput
                                key={input.id}
                                {...input}
                                value={values[input.name]}
                                onChange={onChange}
                            />
                        ))}
                        <button>Add</button>
                    </form>
                </div>
            </div>
        )
    }

    export default InputHandle;
