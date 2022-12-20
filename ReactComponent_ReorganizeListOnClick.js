import React from "react";
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';



// Paste in code from testDome below

const List = (props) => {
  // return an unordered jsx list of items (props.items) with an onClick handler for each item
  // onClick should reorganize the list with the clicked item at the top
  // hint: use Array.prototype.filter and Array.prototype.map

  const [listItems, setListItems] = React.useState(props.items);
  
  // write a function that reorders the list with the clicked item at the top
  const reorg = (e) => {
    // Add the clicked item to the top of the new list
    let newList = [e];

    // Iterate through the listItems array and add each item to the new list if it is not the clicked item
    for (let i = 0; i < listItems.length; i++) {
      if (listItems[i] !== e) {
        newList.push(listItems[i]);
      }
    }
    
    // Set the new list to the state, which should cause a re-render
    setListItems(newList);
  }

  return (
    <ul>
      {listItems.map((item, index) => {
        return <li key={index} onClick={() => reorg(item)}>{item}</li>
      }
      )}
    </ul>
  )
}

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(<List items={["A", "B", "C"]} />, document.getElementById("root"));
setTimeout(() => console.log(document.getElementById("root").innerHTML));
