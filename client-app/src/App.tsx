
import { act, useEffect, useState } from 'react'
import './App.css'
import { DuckItem } from './DuckItem'
import { ducks } from './demo'
import axios from 'axios';
import { Button, Header, List, ListItem } from 'semantic-ui-react';

function App() {
  const [activities,setActivities]=useState([]); 

  useEffect(()=>{
    axios.get('https://localhost:5000/api/activities').then(response=>{
      console.log(response);
      setActivities(response.data)
    })
  },[])

  return (
    <div>     
      <Header as='h2' icon='users' content="Reactivities" />  
        <List>
          {activities.map((activity:any)=>(
            <ListItem key={activity.id}>
            {activity.title}
            </ListItem>
           
          ))}
        </List>
      
      <Button content="Click"></Button>
    </div>  
  )
}

export default App
