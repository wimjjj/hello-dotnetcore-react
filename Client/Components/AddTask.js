import React from "react";

export default class Addtask extends React.Component{

    addTask(e){
        let title = document.getElementById("title").value;

        let task = {
            title,
            done: false
        };

        this.props.addTask(task);
    }

    render(){
        return (
            <form onSubmit={function(e){e.preventDefault()}}>
                <input type="text" name="title" id="title" placeholder="new task" />
                <button onClick={this.addTask.bind(this)}>add</button>
            </form>
        );
    }
}