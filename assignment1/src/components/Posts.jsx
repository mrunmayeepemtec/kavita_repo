import React, { useState, Fragment } from 'react';
import {Button, Table} from 'react-bootstrap';
import data from './mock-data.json';
import './CSS/post.css';
import ReadOnlyRow from './ReadOnlyRow';
import EditableRow from './EditableRow';

const Posts = () => {
    
    const [posts, setPosts] = useState(data);
    const [addFormData, setAddFormData] = useState({
        userId: '',
        id: '',
        title: '',
        body: ''
    });

    const [editFormData, setEditFormData] = useState({
        userId: "",
        id: "",
        title: "",
        body: "",
    })

    const [editPostId, setEditPostId] = useState(null);

    const handlAddFormChange = (e) => {
        e.preventDefault();

        const fieldName = e.target.getAttribute('name');
        const fieldValue = e.target.value;

        const newFormData = { ...addFormData};
        newFormData[fieldName ] = fieldValue;

        setAddFormData(newFormData);
    };

    const handleEditFormChange = (e) =>{
        e.preventDefault();

        const fieldName = e.target.getAttribute('name');
        const fieldValue = e.target.value;

        const newFormData = { ...editFormData };
        newFormData[fieldName] = fieldValue;

        setEditFormData(newFormData);
    }

    const handleAddFormSubmit = (e) =>{
        e.preventDefault();

        const newPost = {
            userId: addFormData.userId,
            id: addFormData.id,
            title: addFormData.title,
            body: addFormData.body
        };

        const newPosts = [...posts, newPost];
        setPosts(newPosts);
    };

    const handleEditFormSubmit = (e) =>{
        e.preventDefault();

        const editedPost = {
            userId: editFormData.userId,
            id: editFormData.id,
            title: editFormData.title,
            body: editFormData.body,
        }

        const newPosts = [ ...posts];

        const index = posts.findIndex((post)=> post.id === editPostId)
        newPosts[index] = editedPost;

        setPosts(newPosts);
        setEditPostId(null)
    };

    const handleEditClick = (e, post) =>{
        e.preventDefault();

        setEditPostId(post.id)

        const formValues = {
            userId: post.userId,
            id: post.id,
            title: post.title,
            body: post.body,
        }

        setEditFormData(formValues)
    }

    const handleCancelClick = () =>{
        setEditPostId('id')
    }

    const handleDeleteClick = (postId) =>{
        const newPosts = [ ...posts];

        const index = posts.findIndex((post) => post.id === postId);

        newPosts.splice(index, 1);

        setPosts(newPosts)

    }

  return (
    <div>
        <h1>Add Posts</h1>
        <div>
        <form onSubmit={handleAddFormSubmit}>
           <input type="text" name="userId" placeholder="Enter userId" onChange={handlAddFormChange} required />
           <input type="text" name="id" placeholder="Enter id" onChange={handlAddFormChange} required />
           <input type="text" name="title" placeholder="Enter title" onChange={handlAddFormChange} required />
           <input type="text" name="body" placeholder="Enter body" onChange={handlAddFormChange} required /> 

        <Button variant="primary" type="submit">Add</Button>
        
      </form>
        </div>
        <br/>

      <div className="container">
        <form handleEditFormSubmit={handleEditFormSubmit}>
       <Table striped bordered hover size="sm">
            <thead>
                <tr>
                    <th>UserId</th>
                    <th>ID</th>
                    <th>Title</th>
                    <th>Body</th>
                    <th>Actions</th>
                </tr>
            </thead>

            <tbody>
               {posts.map((post) => (
                <Fragment>
                    {editPostId === post.id ? (<EditableRow 
                    editFormData={editFormData}
                    handleEditFormChange={handleEditFormChange}
                    handleCancelClick={handleCancelClick}/>) :
                     ( <ReadOnlyRow post={post} 
                    handleEditClick={handleEditClick}
                    handleDeleteClick={handleDeleteClick}/>)}
                   
                </Fragment>
               ))}
            </tbody>
            </Table>
        </form>
    </div>
    </div>
  )
}

export default Posts
