import React from "react";

export default class Addtask extends React.Component{

    addTask(e){
        let titleInput = document.getElementById("title");
        let title = titleInput.value;
        titleInput.value= "";

        let task = {
            title,
            done: false
        };

        this.props.addTask(task);
    }

    render(){
        return (
            <div class="row">
                <form onSubmit={function(e){e.preventDefault()}}>
                    <div class="ten columns">
                        <input type="text" name="title" id="title" placeholder="new task" class="u-full-width" autoFocus/>
                    </div>
                    <div class="two columns">
                        <button onClick={this.addTask.bind(this)} class="button button-primary u-full-width">add</button>
                    </div>
                </form>
            </div>
        );
    }
}