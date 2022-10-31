import React, { useState } from 'react'
import Para from './para'
import './CSS/login.css'

const Login = () => {

    const [addFormData, setAddFormData] = useState({
       email: '',
       password: '',
    });

    const [allEntry, setAllEntry] = useState([]);

    const handlAddFormChange = (e) => {
        e.preventDefault();

        const fieldName = e.target.getAttribute('name');
        const fieldValue = e.target.value;

        const newFormData = { ...addFormData};
        newFormData[fieldName ] = fieldValue;

        setAddFormData(newFormData);
    };

    const handleAddFormSubmit = (e) =>{
        e.preventDefault();

        const newEntry = {
            email: addFormData.email,
            password: addFormData.password,
        };

        const All = [...allEntry, newEntry];
        setAllEntry(All);
    };

  return (
    <div>
      <div className="contact-box">
        <section className="word">
            <span>
                <form onSubmit={handleAddFormSubmit}>
                    <h1>Login Form</h1>
                    <h3>Hello!</h3>
                    <h5>Login in to your account</h5>

                    <div>
                        <label htmlFor="email">Email:-</label>
                        <input type="email" name="email" placeholder="Enter email" onChange={handlAddFormChange} required />
                    </div>
                    <br/>
                    <div>
                        <label htmlFor="password">Password:-</label>
                        <input type="password" name="password" placeholder="Enter password" onChange={handlAddFormChange} required />
                    </div>
                    <br/>
                    <div>
                        <button type="submit">Login</button>
                    </div>
                </form>
            </span>
        </section>

        <Para />
      </div>

      <div>
      <table className="contact-box1">
        <tr>
            <th className="Col">Email</th>
            <th className="Col">Password</th>
        </tr>

        <tbody>
            {
                allEntry.map((e) =>{
                    return(
                        <tr>
                            <td>{e.email}</td>
                            <td>{e.password}</td>
                        </tr>
                    )
                }) 
            }
        </tbody>
      </table>
    </div>
    </div>
  )
}

export default Login
