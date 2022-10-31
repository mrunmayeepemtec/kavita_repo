import React, { useState } from 'react'
import './CSS/registratation.css'

const Registration = () => {

    const [addFormData, setAddFormData] = useState({
        firstName: '',
        lastName:'',
        email: '',
        phone: '',
        password: '',
        confirmPassword: '',
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
            firstName: addFormData.firstName,
            lastName: addFormData.lastName,
             email: addFormData.email,
             phone: addFormData.phone,
             password: addFormData.password,
             confirmPassword: addFormData.confirmPassword,
         };
 
         const All = [...allEntry, newEntry];
         setAllEntry(All);
     };
 
  return (
    <div>
      <div className="contact-box">
        <form onSubmit={handleAddFormSubmit}>
            <h1>Registration Form</h1>

            <div>
                <label htmlFor="firstName">First Name:-</label>
                <input type="text" name="firstName" placeholder="Enter your first name" onChange={handlAddFormChange} required />
            </div>
            <br/>
            <div>
                <label htmlFor="lastName">Last Name:-</label>
                <input type="text" name="lastName" placeholder="Enter your last name" onChange={handlAddFormChange} required />
            </div>
            <br/>

            <div>
                <label htmlFor="email">Email:-</label>
                <input type="email" name="email" placeholder="Enter email" onChange={handlAddFormChange} required />
            </div>
            <br/>

            <div>
                <label htmlFor="phone">Phone:-</label>
                <input type="phone" name="phone" placeholder="Enter phone" onChange={handlAddFormChange} required />
            </div>
            <br/>

            <div>
                <label htmlFor="password">Password:-</label>
                <input type="password" name="password" placeholder="Enter password" onChange={handlAddFormChange} required />
            </div>
            <br/>

            <div>
                <label htmlFor="confirmPassword">Confirm Password:-</label>
                <input type="password" name="confirmPassword" placeholder="Enter confirm password" onChange={handlAddFormChange} required />
            </div>
            <br/>

            <div>
                <button type="submit">Register</button>
            </div>
        </form>
      </div>

      <div>
      <table className="contact-box1">
        <tr>
            <th className="Col">First Name</th>
            <th className="Col">Last Name</th>
            <th className="Col">Email</th>
            <th className="Col">Phone</th>
            <th className="Col">Password</th>
            <th className="Col">Confirm Password</th>
        </tr>

        <tbody>
            {
                allEntry.map((e) =>{
                    return(
                        <tr>
                            <td>{e.firstName}</td>
                            <td>{e.lastName}</td>
                            <td>{e.email}</td>
                            <td>{e.phone}</td>
                            <td>{e.password}</td>
                            <td>{e.confirmPassword}</td>
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

export default Registration
