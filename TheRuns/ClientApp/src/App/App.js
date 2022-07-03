import React, { Component } from "react";
import { Button, Typography } from "@mui/material";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <div className="App">
        <Typography variant="h1" component="h2">
          Inside App Component
        </Typography>
        <Button variant="outlined">I am a button</Button>
      </div>
    );
  }
}
