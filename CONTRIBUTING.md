# Contributing Guide

👍🎉 First off, thanks for taking the time to contribute! 🎉👍

Filing an Issue or a Pull Request is often the best way to address a problem with this library;
however, we may not get to these right away. Although we try to be quick, our primary, daily focus is
writing code. If you want a timely response (especially if you have an emergency), we recommend
you contact our [official support team](https://support.recurly.com/).

## Code of Conduct

Please note that this project is released with a [Contributor Code of Conduct](CODE_OF_CONDUCT.md). By participating in this project you agree to abide by its terms.

#### Table Of Contents

* [I don't want to read this whole thing, I just have a question!!!](#i-dont-want-to-read-this-whole-thing-i-just-have-a-question)
* [I think something is wrong with this library](#i-think-something-is-wrong-with-this-library)
* [I know what's wrong and I want to submit a code change](#i-know-whats-wrong-and-i-want-to-submit-a-code-change)
  * [Development Dependencies](#development-dependencies)
  * [Building and Testing](#building-and-testing)
  * [Formatting Code](#formatting-code)
  * [Generated Code](#generated-code)


## I don't want to read this whole thing I just have a question!!!

The best way to get a question answered is through our [official support channel](https://support.recurly.com/). If you
have a specific question related to this library and cannot find an answer, feel free to post an issue with the question.

## I think something is wrong with this library

Are you getting an exception or seeing some unexpected behavior from the library? An issue is the way to go.
Submit an issue and make sure you provide as much detail as possible. Some things you'll want to include:

* Your dependency versions (client version, language version, OS, etc)
* A stack trace if available
* A [Minimal, Reproducible Example](https://stackoverflow.com/help/minimal-reproducible-example)

The more information you give us, the quicker and easier the response will be. Keep in mind that issues should be scoped
to a problem in this library and we may often redirect you to our official support for problems originating from
upstream systems.

## I know what's wrong and I want to submit a code change

So, you are sure you want to submit a change to the code? We appreciate the help!
Before you do, consider opening a discussion in the form of an issue. This accomplish a few things:

1. We can give you advice to implement the change
2. We can give you an idea of our openness to the change

**Note**: Sending code without a discussion is *always* fine. Discussion on the PR is often easier anyway. Just understand that we may
not accept the code if we don't think it's best for everyone using the library.

The rest of this section describes what you'll need to know.

### Development Dependencies

You're going to first need a supported version of the language toolchain. The best way to find which versions are supported are by checking
the [Travis File](.travis.yml) which is used to run our tests. We try to test against every supported version of the language. The [README](README.md)
may also have something to say about supported dependencies.

### Building and Testing

All of our client libraries contain a `scripts` folder which houses a set of bash scripts for doing common
development tasks. These scripts follow the same naming conventions so this can act as a kind of "Bash API"
for manipulating the libraries.

**Note**: If you are on a system without bash (such as some Windows systems), you should find the scripts only consist of a
few commands which can easily be run in your terminal or editor directly.

Start by running the `build` script to setup deps, compile (if applicable), build docs, etc:

```bash
./scripts/build
```

Use the `test` script to run the tests:

```bash
./scripts/test
```

Make sure the tests pass locally before submitting your change.

### Formatting Code

The PR (and often the tests) will fail if you have not properly formatted the code. Instead of having a style-guide, we've provided
an auto-formatter. To use it, run the `format` script:

```bash
./scripts/format
```

### Generated Code

Some files in this codebase are generated by a non-public, proprietary program. Because they are regularly generated and updated as the
API and docs change, we won't accept any PRs that modify these files. Each of these files has a disclaimer on the top saying that they cannot
be edited by hand. By convention, they relate to things that are specific to the Recurly API that may change. For example:

* Response Schemas (Resources)
* Request Schemas (Requests)
* API endpoints (Operations)
* Errors

If you feel like you need one of these to change, please file an issue and we can discuss getting the change upstreamed.
